namespace PizzeriaCompagnone.Models
{
    public class Pizza
    {
        public int id { get; set; } 
        public string title { get; set; }

        public string ingredienti { get; set; }

        public string image { get; set; }

        public string image2 { get; set; }

        public double prezzo { get; set; }

        public Pizza()
        {

        }
        public Pizza(int id, string title, string ingredienti, string image, string image2, double prezzo)
        {
            this.id = id;
            this.title = title;
            this.ingredienti = ingredienti;
            this.image = image;
            this.image2= image2;
            this.prezzo = prezzo;
        }
    }
}
