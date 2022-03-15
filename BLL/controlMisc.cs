using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Data;
using DAL;
using System.Globalization;

namespace BLL
{
    public class controlMisc
    {
        public static void LinkButtonAction(Panel pn)
        {
            if (pn.Visible == true)
            {
                pn.Visible = false;
            }
            else
            {
                pn.Visible = true;
            }
        }

        public static void RefreshUserDDL(DropDownList ddl, Label lb) 
        {
            lb.Text = ddl.Text + "'s ";
            int ind = ddl.SelectedIndex;
            ddl.AppendDataBoundItems = false;
            string[] _initial = new string[] { "Select user" };
            ddl.DataSource = _initial;
            ddl.DataBind();
            ddl.AppendDataBoundItems = true;
            controlMembership.PopulateUsersDDL(ddl);
            ddl.SelectedIndex = ind;
        }

        public static bool RowExist(DataTable dt, string _product)
        {
            string[] theList = FetchColumnContents(dt, 1);
            bool test = IsItemInList(_product, theList);
            return test;
        }

        public static bool IsItemInList(string item, string[] list)
        {
            bool check = false;
            for (int i = 0; i < list.Length; i++)
            {
                string listItem = list[i];
                if (item == listItem)
                {
                    check = true;
                    return check;
                }
            }
            return check;
        }

        public static string[] FetchColumnContents(DataTable dt, int colIndex)
        {
            DataRow[] aRowList = dt.Select();
            string[] aList = new string[aRowList.Length];
            int j = 0;
            for (int i = 0; i < aRowList.Length; i++)
            {
                string _item = aRowList[i][colIndex].ToString();

                aList[j] = _item;
                j++;
            }
            return aList;
        }

        public static object GetItemByProductName(DataTable dt, string _name, int itemColIndex)
        {
            string[] _products = FetchColumnContents(dt, 1);
            int myIndex = GetListItemIndex(_name, _products);
            var _item = Convert.ToInt32(FetchColumnContents(dt, itemColIndex)[myIndex]);
            return _item;
        }

        public static int GetListItemIndex(string item, string[] list)
        {
            int itemIndex = -1;
            for (int i = 0; i < list.Length; i++)
            {
                string listItem = list[i];
                if (item == listItem)
                {
                    itemIndex = i;
                }
            }
            return itemIndex;
        }

        public static DataTable CreateCartTable()
        {
            DataTable myCartTable = new DataTable();

            DataColumn No = new DataColumn("No", Type.GetType("System.Int32"));
            myCartTable.Columns.Add(No);
            DataColumn Products = new DataColumn("Products", Type.GetType("System.String"));
            myCartTable.Columns.Add(Products);
            DataColumn Price = new DataColumn("Prices", Type.GetType("System.Int32"));
            myCartTable.Columns.Add(Price);
            DataColumn Quantity = new DataColumn("Quantity", Type.GetType("System.Int32"));
            myCartTable.Columns.Add(Quantity);
            ButtonField bf = new ButtonField();
            DataColumn Delete = new DataColumn("Delete", bf.GetType());
            myCartTable.Columns.Add(Delete);
            DataColumn[] keys = new DataColumn[2];
            keys[0] = No;
            keys[1] = Products;
            myCartTable.PrimaryKey = keys;

            return myCartTable;
        }

        public static int SumColumnValues(DataTable table, int priceColIndex, int quantityColIndex)
        {
            DataRow[] productList = table.Select();
            int aSum = 0;
            for (int i = 0; i < productList.Length; i++)
            {
                int something = (int)productList[i][priceColIndex] * (int)productList[i][quantityColIndex];
                aSum = aSum + something;
            }
            return aSum;
        }

        public static void UpdateCartTable(DataTable dt, int _quantity, int indexNo)
        {
            DataRow[] daRow = dt.Select("No = '" + indexNo + "'");
            daRow[0][3] = _quantity;
        }

        public static void SubmitOrder(DataTable dt) 
        {
            MembershipUser user = Membership.GetUser();
            string _userName = user.UserName;

            DataRow[] productList = dt.Select();
            int aSum = 0;
            for (int i = 0; i < productList.Length; i++)
            {
                int something = (int)productList[i][3];
                aSum = aSum + something;
            }

            int totalPrice = SumColumnValues(dt, 2, 3);

            string _time = DateTime.Now.ToString();

            string[] orderedProducts = FetchColumnContents(dt, 1);
            int[] productId = myCRUD.FetchProductId(orderedProducts);

            myCRUD.InsertOrder(_userName, aSum, totalPrice, _time);

            DataRow[] aRowList = dt.Select();
            int[] aList = new int[aRowList.Length];
            int j = 0;
            for (int i = 0; i < aRowList.Length; i++)
            {
                int _item = (int)aRowList[i][3];

                aList[j] = _item;
                j++;
            }

            myCRUD.InsertOrderedProducts(_time, productId, aList);
        }

        public static bool ProductExists(string str) 
        {
            try
            {
                myCRUD.FetchPrice(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
