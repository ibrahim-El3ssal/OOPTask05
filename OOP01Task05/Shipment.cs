using System;

namespace OOP01Task05
{
    internal struct Shipment
    {
        private string TrackingCode;
        private string Description;
        private double Weight;
        private decimal DeliveryFee;
        public DeliveryAddress Destination;

        // 1. Main Constructor
        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = "UNKNOWN";
            Description = "N/A";
            Weight = 1.0;
            DeliveryFee = 1.0m;
            Destination = destination;

            SetTrackingCode(trackingCode);
            SetDescription(description);
            SetWeight(weight);
            SetDeliveryFee(deliveryFee);
            SetDestination(destination);
        }

        // 2. Overloaded Constructor
        public Shipment(string trackingCode)
            : this(trackingCode, "Unknown", 1.0, 50.0m, new DeliveryAddress())
        {
        }

        // TrackingCode 
        public string GetTrackingCode()
        {
            return TrackingCode;
        }
        private void SetTrackingCode(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                TrackingCode = value;
            }
        }

        // Description
        public string GetDescription()
        {
            return Description;
        }
        public void SetDescription(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                Description = value;
            }
        }

        // Weight
        public double GetWeight()
        {
            return Weight;
        }
        public void SetWeight(double value)
        {
            if (value > 0)
            {
                Weight = value;
            }
        }

        // DeliveryFee
        public decimal GetDeliveryFee()
        {
            return DeliveryFee;
        }
        private void SetDeliveryFee(decimal value)
        {
            if (value > 0)
            {
                DeliveryFee = value;
            }
        }

        // Destination
        public DeliveryAddress GetDestination()
        {
            return Destination;
        }
        public void SetDestination(DeliveryAddress value)
        {
            Destination = value;
        }

        // EstimatedCost 
        public decimal EstimatedCost()
        {
            return DeliveryFee + (decimal)(Weight * 5);
        }

        // UpdateDeliveryFee
        public void UpdateDeliveryFee(decimal newFee)
        {
            SetDeliveryFee(newFee);
        }
        //PrintShipment
        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: {DeliveryFee:C}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost():C}");
        }
    }
}