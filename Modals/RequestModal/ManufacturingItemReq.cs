using System.ComponentModel.DataAnnotations;

namespace ManufacturingAPI.Modals.RequestModal
{
    public class ManufacturingItemReq
    {
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(255, ErrorMessage = "Name cannot exceed 255 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "District is required")]
        [MaxLength(100, ErrorMessage = "District cannot exceed 100 characters")]
        public string District { get; set; }
        [Required(ErrorMessage = "Status is required")]
        [MaxLength(50, ErrorMessage = "Status cannot exceed 50 characters")]
        public string Status { get; set; }
       
    }
    public class UpdateManufacturingItem : ManufacturingItemReq
    {
        public int Id { get; set; }

    }
}
