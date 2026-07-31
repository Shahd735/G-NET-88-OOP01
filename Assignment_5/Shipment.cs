using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public struct Shipment
    {
        private string _trackingCode;
        private string _description;
        private double _weight;
        private decimal _deliveryFee;

        public string TrackingCode
        {
            get { return _trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingCode = value;
                }
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }

        public DeliveryAddress Destination { get; set; }

        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5);
            }
        }

        public Shipment(string trackingCode)
        {
            _trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN-CODE";

            _description = "Unknown";
            _weight = 1.0;
            _deliveryFee = 50m;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            _trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN-CODE";
            _description = !string.IsNullOrWhiteSpace(description) ? description : "Unknown";
            _weight = weight > 0 ? weight : 1.0;
            _deliveryFee = deliveryFee > 0 ? deliveryFee : 50m;

            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                _deliveryFee = newFee;
            }
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code:  {TrackingCode}");
            Console.WriteLine($"Description:    {Description}");
            Console.WriteLine($"Weight:         {Weight} kg");
            Console.WriteLine($"Delivery Fee:   {DeliveryFee}");
            Console.WriteLine($"Destination:    {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }
    }
}
