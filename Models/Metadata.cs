using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _25dh230046_MyStore.Models
{
    public class CategoryMetadata
    {
        [HiddenInput]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string CategoryName { get; set; }
    }
    public class UserMetadata
    {
        [Required(ErrorMessage = "Username is required!")]
        [StringLength(30, MinimumLength = 5)]
        [RegularExpression("\r\n ^[a-zA-Z0-9]([._-](?![._-])|[a-zA-Z0-9]){3,18}[a-zA-Z0-9]$\r\n")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string UserRole { get; set; }
    }

    public class ProductMetadata
    {
        [DisplayName("Mã sản phẩm")]
        public int ProductID { get; set; }


        [StringLength(50)]
        [Required(ErrorMessage = "Phải nhập tên sản phẩm!")]
        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }


        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Số tiền phải lớn hơn 0.")]
        public decimal ProductPrice { get; set; }


        [DisplayName("Chủng loại sản phẩm")]
        public int CategoryID { get; set; }

        [DisplayName("Đường dẫn ảnh sản phẩm")]
        [DefaultValue("~/Content/Images/default_img.jfif")]
        public string ProductImage { get; set; }

        [DisplayName("Mô tả sản phẩm")]
        public string NameDescription { get; set; }

        [DefaultValue(true)]
        public System.DateTime CreatedDate { get; set; }

        //[NotMapped]
        //public HttpPostedFileBase UploadImage { get; set; }

        //[NotMapped]
        //public List<ProDetail> RemainProducts { get; set; }

        //[NotMapped]
        //public List<ProDetail> NeedImportProducts { get; set; }
    }

    public class CustomerMetadata
    {
        [DisplayName("Mã khách hàng")]
        public int CustomerID { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Phải nhập tên khách hàng!")]
        [DisplayName("Tên khách hàng")]
        public string CustomerName { get; set; }


        [StringLength(10)]
        [DisplayName("Số điện thoại khách hàng")]
        public string CustomerPhone { get; set; }

        [StringLength(100)]
        [DisplayName("Email khách hàng")]
        public string CustomerEmail { get; set; }

        [StringLength(200)]
        [DisplayName("Địa chỉ khách hàng")]
        public string CustomerAddress { get; set; }


        [StringLength(30)]
        [DisplayName("Tên đăng nhập")]
        public string Username { get; set; }
    }

    public class  OrderMetadata
    {
        [DisplayName("Mã đơn hàng")]
        public int OrderID { get; set; }

        [DisplayName("Mã khách hàng")]
        public int CustomerID { get; set; }

        [DisplayName("Ngày đặt hàng")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime OrderDate { get; set; }

        [DisplayName("Tổng số tiền")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalAmount { get; set; }

        [DisplayName("Trạng thái thanh toán")]
        public string PaymentStatus { get; set; }

        [DisplayName("Địa chỉ giao hàng")]
        public string AddressDelivery { get; set; }
    }

    public class OrderDetailMetadata
    {
        [DisplayName("Mã chi tiết đơn hàng")]
        public int ID { get; set; }

        [DisplayName("Mã sản phẩm")]
        public int ProductID { get; set; }

        [DisplayName("Mã đơn hàng")]
        public int OrderID { get; set; }

        [DisplayName("Số lượng")]
        [Required]
        public int Quantity { get; set; }

        [DisplayName("Đơn giá")]
        public decimal UnitPrice { get; set; }
    }


}
