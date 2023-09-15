using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab15_16
{
   public class Clock
    {
        private string brand;
        private string model;
        private string type_of_mechanism;
        private string body_material;
        private string type_of_bracelet;
        private double size_in_inches;
        private double price;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string TypeOfMechanism
        {
            get { return type_of_mechanism; }
            set { type_of_mechanism = value; }
        }

        public string BodyMaterial
        {
            get { return body_material; }
            set { body_material = value; }
        }

        public string TypeOfBracelet
        {
            get { return type_of_bracelet; }
            set { type_of_bracelet = value; }
        }

        public double SizeInInches
        {
            get { return size_in_inches; }
            set { size_in_inches = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Clock() { }
        public Clock(string brand, string model, string type_of_mechanism, string body_material, string type_of_bracelet, double size_in_inches, int price)
        {
            this.brand = brand;
            this.model = model;
            this.type_of_mechanism = type_of_mechanism;
            this.body_material = body_material;
            this.type_of_bracelet = type_of_bracelet;
            this.size_in_inches = size_in_inches;
            this.price = price;
        }
        
        public double CalculatePriceWithTax(string brand, string model)
        {

            double tax = 10.0;
            double  finalprice = this.price * (tax / 100.0);
            return finalprice + this.Price;
        }

        public void ChangeBracelet(string newBracelet)
        {
            TypeOfBracelet = newBracelet;
        }

        public string GetFullInfo()
        {
            string description = $"Brand: {Brand}\nModel: {Model}\nType of Mechanism: {TypeOfMechanism}\nBody Material: {BodyMaterial}\nType of Bracelet: {TypeOfBracelet}\nSize in Inches: {SizeInInches}\nPrice: {Price}";
            return description;
        }

        public void FindByBrand(string brand)
        {
            if (this.Brand == brand)
            {
                GetFullInfo();
            }
        }

    }
}
