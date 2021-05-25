

namespace OOP_KURS
{
    public class Therapy : Services
    {
        string therapyType;
        public Therapy(string therapyType, string name, int price) : base(name, price)
        {
            this.therapyType = therapyType;
        }
        public string thisTherapyType
        {
            get { return this.therapyType; }
            set { this.therapyType = value is string ? value : null; }
        }
    }
}
