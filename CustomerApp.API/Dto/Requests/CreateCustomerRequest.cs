using System.ComponentModel.DataAnnotations;

namespace CustomerApp.API.Dto.Requests
{
    public class CreateCustomerRequest
    {
        [Required(ErrorMessage = "Customer Code tidak boleh kosong.")]
        [StringLength(50, ErrorMessage = "Customer Code maksimal 50 karakter.")]
        public required string CustomerCode { get; set; } 

        [Required(ErrorMessage = "Customer Name tidak boleh kosong.")]
        [StringLength(255, ErrorMessage = "Customer Name maksimal 255 karakter.")]
        public required string CustomerName { get; set; } 

        [Required(ErrorMessage = "Customer Address tidak boleh kosong.")]
        [StringLength(1000, ErrorMessage = "Customer Address maksimal 1000 karakter.")]
        public required string CustomerAddress { get; set; } 

        [Required(ErrorMessage = "Created By tidak boleh kosong.")]
        public required int CreatedBy { get; set; } 
    }
}
