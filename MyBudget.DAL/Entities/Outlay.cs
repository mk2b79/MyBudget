namespace MyBudget.DAL.Entities
{
    public class Outlay
    {
        public int Id { get; set; }
        public decimal Money { get; set; }
        public Category? Category { get; set; }
        public string? Description { get; set; }

        //public int CategoryId {  get; set; }
    }
}
