namespace GoCafe.Pages.Order
{
    public class ObjOrder
    {
        public string id { get; set; }
        public int SL { get; set; }
        public ObjOrder(string id, int SL)
        {
            this.id=id;
            this.SL=SL;
        }
    }
}