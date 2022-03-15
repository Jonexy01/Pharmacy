using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public class myCRUD
    {
        public static List<string> FetchSomeProducts(string prefixText) 
        {
            using (pharmacyLinqDataContext db = new pharmacyLinqDataContext())
            {
                var _poducts = from p in db.Products where p.Name.StartsWith(prefixText) select p.Name;
                return _poducts.ToList();
            }
        }

        public static void FetchProduct(string st) 
        {
            using (pharmacyLinqDataContext db = new pharmacyLinqDataContext())
            {
                var dt = db.Products.SingleOrDefault(dat => dat.Name == st);
                var _price = dt.Price;
                //return Convert.ToInt32(_price);
            }
        }

        public static int FetchPrice(string st)
        {
            using (pharmacyLinqDataContext db = new pharmacyLinqDataContext())
            {
                var dt = db.Products.SingleOrDefault(dat => dat.Name == st);
                var _price = dt.Price;
                return Convert.ToInt32(_price);
            }
        }

        public static Guid FetchUserId(string aUser)
        {
            using (pharmacyLinqDataContext db = new pharmacyLinqDataContext())
            {
                try
                {
                    var dt = db.aspnet_Users.SingleOrDefault(dat => dat.UserName == aUser);
                    var _userId = dt.UserId;
                    return _userId;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static void InsertOrder(string _user, int _noProduct, int _totalPrice, string _time)
        {
            var _userId = FetchUserId(_user);
            using (pharmacyLinqDataContext db = new pharmacyLinqDataContext())
            {
                Order newOrder = new Order();
                newOrder.UserId = _userId;
                newOrder.UserName = _user;
                newOrder.No_of_Products = _noProduct;
                newOrder.Total_Price = _totalPrice;
                newOrder.Date = _time;
                newOrder.Serial = GetSerial();
                newOrder.Completed = "no";
                db.Orders.InsertOnSubmit(newOrder);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static int GetSerial() 
        {
            using (pharmacyLinqDataContext db = new pharmacyLinqDataContext())
            {
                var dt = db.tests.SingleOrDefault(dat => dat.theId == "main");
                int serial = dt.first;
                int no = serial;
                no++;
                dt.first = no;
                db.SubmitChanges();
                return serial;
            }
        }

        public static void InsertOrderedProducts(string time, int[] pList, int[] qList)
        {
            int _orderId = FetchOrderId(time);
            using (pharmacyLinqDataContext db = new pharmacyLinqDataContext())
            {
                for (int i = 0; i < pList.Length; i++)
                {
                    OrderedProduct _products = new OrderedProduct();
                    _products.OrderId = _orderId;
                    _products.ProductId = pList[i];
                    _products.Quantity = qList[i];
                    db.OrderedProducts.InsertOnSubmit(_products);
                    db.SubmitChanges();
                }
            }
        }

        public static int FetchOrderId(string time)
        {
            using (pharmacyLinqDataContext db = new pharmacyLinqDataContext())
            {
                var dt = db.Orders.SingleOrDefault(dat => dat.Date == time);
                int _orderId = dt.OrderId;
                return _orderId;
            }
        }

        public static int[] FetchProductId(string[] _products)
        {
            using (pharmacyLinqDataContext db = new pharmacyLinqDataContext())
            {
                int length = _products.Length;
                int[] _productId = new int[length];
                for (int i = 0; i < length; i++)
                {
                    var dt = db.Products.SingleOrDefault(dat => dat.Name == _products[i]);
                    _productId[i] = dt.ProductId;
                }
                return _productId;
            }
        }

        public static void ResetSerial() 
        {
            string _date = DateTime.Now.ToShortDateString();
            
            using (pharmacyLinqDataContext db = new pharmacyLinqDataContext())
            {
                var dt = db.tests.SingleOrDefault(dat => dat.theId == "main");
                string _initDate = dt.Date;
                if (_date != _initDate)
                {
                    dt.first = 1;
                    dt.Date = _date;
                    db.SubmitChanges();
                }
            }
        }

        public static bool UpdateCompleted(string _user, int _serial) 
        {
            string _date = DateTime.Now.ToShortDateString();
            int _id;

            using (pharmacyLinqDataContext db = new pharmacyLinqDataContext()) 
            {
                try
                {
                    var dt = db.Orders.SingleOrDefault(dat => dat.UserName == _user && dat.Serial == _serial && dat.Date.StartsWith(_date));
                    if (dt.Completed == "no")
                    {
                        _id = dt.OrderId;
                        dt.Completed = "yes";
                        var _productsId = (from p in db.OrderedProducts where p.OrderId == _id select p.ProductId).ToList();
                        var _quantity = (from q in db.OrderedProducts where q.OrderId == _id select q.Quantity).ToList();
                        for (int i = 0; i < _productsId.Count; i++)
                        {
                            var aRow = db.Products.SingleOrDefault(dat => dat.ProductId == _productsId[i]);
                            aRow.Quantity -= _quantity[i];
                        }

                        db.SubmitChanges();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                
            }
        }

        public static bool UpdateCompleted(string _user, int _serial, string _date)
        {
            int _id;

            using (pharmacyLinqDataContext db = new pharmacyLinqDataContext())
            {
                try
                {
                    var dt = db.Orders.SingleOrDefault(dat => dat.UserName == _user && dat.Serial == _serial && dat.Date.StartsWith(_date));
                    if (dt.Completed == "no")
                    {
                        _id = dt.OrderId;
                        dt.Completed = "yes";
                        var _productsId = (from p in db.OrderedProducts where p.OrderId == _id select p.ProductId).ToList();
                        var _quantity = (from q in db.OrderedProducts where q.OrderId == _id select q.Quantity).ToList();
                        for (int i = 0; i < _productsId.Count; i++)
                        {
                            var aRow = db.Products.SingleOrDefault(dat => dat.ProductId == _productsId[i]);
                            aRow.Quantity -= _quantity[i];
                        }

                        db.SubmitChanges();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                
            }
        }
    }
}
