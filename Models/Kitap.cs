namespace KitapListelemee.Models
{
    public class Kitap
    {
        public  int Id { get; set; }
        public string KitapAd { get; set; }         
        public string Yazar {  get; set; }
        public string KitapTür {  get; set; }
        public string YayınEvi { get; set; }
    }
}
