﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Pharmacy")]
	public partial class pharmacyLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void Insertaspnet_User(aspnet_User instance);
    partial void Updateaspnet_User(aspnet_User instance);
    partial void Deleteaspnet_User(aspnet_User instance);
    partial void InsertOrderedProduct(OrderedProduct instance);
    partial void UpdateOrderedProduct(OrderedProduct instance);
    partial void DeleteOrderedProduct(OrderedProduct instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void Inserttest(test instance);
    partial void Updatetest(test instance);
    partial void Deletetest(test instance);
    #endregion
		
		public pharmacyLinqDataContext() : 
				base(global::Model.Properties.Settings.Default.PharmacyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public pharmacyLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public pharmacyLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public pharmacyLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public pharmacyLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<aspnet_User> aspnet_Users
		{
			get
			{
				return this.GetTable<aspnet_User>();
			}
		}
		
		public System.Data.Linq.Table<OrderedProduct> OrderedProducts
		{
			get
			{
				return this.GetTable<OrderedProduct>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<test> tests
		{
			get
			{
				return this.GetTable<test>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductId;
		
		private string _Name;
		
		private string _Description;
		
		private System.Nullable<int> _Price;
		
		private System.Nullable<int> _Quantity;
		
		private System.Nullable<System.DateTime> _Last_update;
		
		private EntitySet<OrderedProduct> _OrderedProducts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnLast_updateChanging(System.Nullable<System.DateTime> value);
    partial void OnLast_updateChanged();
    #endregion
		
		public Product()
		{
			this._OrderedProducts = new EntitySet<OrderedProduct>(new Action<OrderedProduct>(this.attach_OrderedProducts), new Action<OrderedProduct>(this.detach_OrderedProducts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(50)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Last update]", Storage="_Last_update", DbType="Date")]
		public System.Nullable<System.DateTime> Last_update
		{
			get
			{
				return this._Last_update;
			}
			set
			{
				if ((this._Last_update != value))
				{
					this.OnLast_updateChanging(value);
					this.SendPropertyChanging();
					this._Last_update = value;
					this.SendPropertyChanged("Last_update");
					this.OnLast_updateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderedProduct", Storage="_OrderedProducts", ThisKey="ProductId", OtherKey="ProductId")]
		public EntitySet<OrderedProduct> OrderedProducts
		{
			get
			{
				return this._OrderedProducts;
			}
			set
			{
				this._OrderedProducts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_OrderedProducts(OrderedProduct entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_OrderedProducts(OrderedProduct entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.aspnet_Users")]
	public partial class aspnet_User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ApplicationId;
		
		private System.Guid _UserId;
		
		private string _UserName;
		
		private string _LoweredUserName;
		
		private string _MobileAlias;
		
		private bool _IsAnonymous;
		
		private System.DateTime _LastActivityDate;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnApplicationIdChanging(System.Guid value);
    partial void OnApplicationIdChanged();
    partial void OnUserIdChanging(System.Guid value);
    partial void OnUserIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnLoweredUserNameChanging(string value);
    partial void OnLoweredUserNameChanged();
    partial void OnMobileAliasChanging(string value);
    partial void OnMobileAliasChanged();
    partial void OnIsAnonymousChanging(bool value);
    partial void OnIsAnonymousChanged();
    partial void OnLastActivityDateChanging(System.DateTime value);
    partial void OnLastActivityDateChanged();
    #endregion
		
		public aspnet_User()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApplicationId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ApplicationId
		{
			get
			{
				return this._ApplicationId;
			}
			set
			{
				if ((this._ApplicationId != value))
				{
					this.OnApplicationIdChanging(value);
					this.SendPropertyChanging();
					this._ApplicationId = value;
					this.SendPropertyChanged("ApplicationId");
					this.OnApplicationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoweredUserName", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string LoweredUserName
		{
			get
			{
				return this._LoweredUserName;
			}
			set
			{
				if ((this._LoweredUserName != value))
				{
					this.OnLoweredUserNameChanging(value);
					this.SendPropertyChanging();
					this._LoweredUserName = value;
					this.SendPropertyChanged("LoweredUserName");
					this.OnLoweredUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MobileAlias", DbType="NVarChar(16)")]
		public string MobileAlias
		{
			get
			{
				return this._MobileAlias;
			}
			set
			{
				if ((this._MobileAlias != value))
				{
					this.OnMobileAliasChanging(value);
					this.SendPropertyChanging();
					this._MobileAlias = value;
					this.SendPropertyChanged("MobileAlias");
					this.OnMobileAliasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsAnonymous", DbType="Bit NOT NULL")]
		public bool IsAnonymous
		{
			get
			{
				return this._IsAnonymous;
			}
			set
			{
				if ((this._IsAnonymous != value))
				{
					this.OnIsAnonymousChanging(value);
					this.SendPropertyChanging();
					this._IsAnonymous = value;
					this.SendPropertyChanged("IsAnonymous");
					this.OnIsAnonymousChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastActivityDate", DbType="DateTime NOT NULL")]
		public System.DateTime LastActivityDate
		{
			get
			{
				return this._LastActivityDate;
			}
			set
			{
				if ((this._LastActivityDate != value))
				{
					this.OnLastActivityDateChanging(value);
					this.SendPropertyChanging();
					this._LastActivityDate = value;
					this.SendPropertyChanged("LastActivityDate");
					this.OnLastActivityDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="aspnet_User_Order", Storage="_Orders", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.aspnet_User = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.aspnet_User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderedProduct")]
	public partial class OrderedProduct : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderedProductId;
		
		private System.Nullable<int> _OrderId;
		
		private System.Nullable<int> _ProductId;
		
		private System.Nullable<int> _Quantity;
		
		private EntityRef<Product> _Product;
		
		private EntityRef<Order> _Order;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderedProductIdChanging(int value);
    partial void OnOrderedProductIdChanged();
    partial void OnOrderIdChanging(System.Nullable<int> value);
    partial void OnOrderIdChanged();
    partial void OnProductIdChanging(System.Nullable<int> value);
    partial void OnProductIdChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    #endregion
		
		public OrderedProduct()
		{
			this._Product = default(EntityRef<Product>);
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderedProductId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderedProductId
		{
			get
			{
				return this._OrderedProductId;
			}
			set
			{
				if ((this._OrderedProductId != value))
				{
					this.OnOrderedProductIdChanging(value);
					this.SendPropertyChanging();
					this._OrderedProductId = value;
					this.SendPropertyChanged("OrderedProductId");
					this.OnOrderedProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", DbType="Int")]
		public System.Nullable<int> OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int")]
		public System.Nullable<int> ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderedProduct", Storage="_Product", ThisKey="ProductId", OtherKey="ProductId", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.OrderedProducts.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.OrderedProducts.Add(this);
						this._ProductId = value.ProductId;
					}
					else
					{
						this._ProductId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderedProduct", Storage="_Order", ThisKey="OrderId", OtherKey="OrderId", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.OrderedProducts.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.OrderedProducts.Add(this);
						this._OrderId = value.OrderId;
					}
					else
					{
						this._OrderId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Order");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderId;
		
		private System.Guid _UserId;
		
		private string _UserName;
		
		private int _Serial;
		
		private int _No_of_Products;
		
		private int _Total_Price;
		
		private string _Date;
		
		private string _Completed;
		
		private EntitySet<OrderedProduct> _OrderedProducts;
		
		private EntityRef<aspnet_User> _aspnet_User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnUserIdChanging(System.Guid value);
    partial void OnUserIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnSerialChanging(int value);
    partial void OnSerialChanged();
    partial void OnNo_of_ProductsChanging(int value);
    partial void OnNo_of_ProductsChanged();
    partial void OnTotal_PriceChanging(int value);
    partial void OnTotal_PriceChanged();
    partial void OnDateChanging(string value);
    partial void OnDateChanged();
    partial void OnCompletedChanging(string value);
    partial void OnCompletedChanged();
    #endregion
		
		public Order()
		{
			this._OrderedProducts = new EntitySet<OrderedProduct>(new Action<OrderedProduct>(this.attach_OrderedProducts), new Action<OrderedProduct>(this.detach_OrderedProducts));
			this._aspnet_User = default(EntityRef<aspnet_User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._aspnet_User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Serial", DbType="Int NOT NULL")]
		public int Serial
		{
			get
			{
				return this._Serial;
			}
			set
			{
				if ((this._Serial != value))
				{
					this.OnSerialChanging(value);
					this.SendPropertyChanging();
					this._Serial = value;
					this.SendPropertyChanged("Serial");
					this.OnSerialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[No of Products]", Storage="_No_of_Products", DbType="Int NOT NULL")]
		public int No_of_Products
		{
			get
			{
				return this._No_of_Products;
			}
			set
			{
				if ((this._No_of_Products != value))
				{
					this.OnNo_of_ProductsChanging(value);
					this.SendPropertyChanging();
					this._No_of_Products = value;
					this.SendPropertyChanged("No_of_Products");
					this.OnNo_of_ProductsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Total Price]", Storage="_Total_Price", DbType="Int NOT NULL")]
		public int Total_Price
		{
			get
			{
				return this._Total_Price;
			}
			set
			{
				if ((this._Total_Price != value))
				{
					this.OnTotal_PriceChanging(value);
					this.SendPropertyChanging();
					this._Total_Price = value;
					this.SendPropertyChanged("Total_Price");
					this.OnTotal_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Completed", DbType="VarChar(50)")]
		public string Completed
		{
			get
			{
				return this._Completed;
			}
			set
			{
				if ((this._Completed != value))
				{
					this.OnCompletedChanging(value);
					this.SendPropertyChanging();
					this._Completed = value;
					this.SendPropertyChanged("Completed");
					this.OnCompletedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderedProduct", Storage="_OrderedProducts", ThisKey="OrderId", OtherKey="OrderId")]
		public EntitySet<OrderedProduct> OrderedProducts
		{
			get
			{
				return this._OrderedProducts;
			}
			set
			{
				this._OrderedProducts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="aspnet_User_Order", Storage="_aspnet_User", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public aspnet_User aspnet_User
		{
			get
			{
				return this._aspnet_User.Entity;
			}
			set
			{
				aspnet_User previousValue = this._aspnet_User.Entity;
				if (((previousValue != value) 
							|| (this._aspnet_User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._aspnet_User.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._aspnet_User.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(System.Guid);
					}
					this.SendPropertyChanged("aspnet_User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_OrderedProducts(OrderedProduct entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_OrderedProducts(OrderedProduct entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.test")]
	public partial class test : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _theId;
		
		private int _first;
		
		private string _Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntheIdChanging(string value);
    partial void OntheIdChanged();
    partial void OnfirstChanging(int value);
    partial void OnfirstChanged();
    partial void OnDateChanging(string value);
    partial void OnDateChanged();
    #endregion
		
		public test()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_theId", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string theId
		{
			get
			{
				return this._theId;
			}
			set
			{
				if ((this._theId != value))
				{
					this.OntheIdChanging(value);
					this.SendPropertyChanging();
					this._theId = value;
					this.SendPropertyChanged("theId");
					this.OntheIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first", DbType="Int NOT NULL")]
		public int first
		{
			get
			{
				return this._first;
			}
			set
			{
				if ((this._first != value))
				{
					this.OnfirstChanging(value);
					this.SendPropertyChanging();
					this._first = value;
					this.SendPropertyChanged("first");
					this.OnfirstChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="NVarChar(50)")]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591