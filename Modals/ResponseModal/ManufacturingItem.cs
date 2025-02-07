namespace ManufacturingAPI.Modals.ResponseModal
{
    public class ManufacturingItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string District { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
