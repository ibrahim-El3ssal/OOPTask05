using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace OOP01Task05
{
    internal struct Shipment
    {
        private string TrackingCode; 
        private string Description;
        private double Weight;
        private double DeliveryFee;
        public DeliveryAddress Destination;

        public Shipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = "UNKNOWN";
            Description = "N/A";
            Weight = 1.0;
            DeliveryFee = 1.0;
            Destination = destination;

            SetTrackingCode(trackingCode)  ;
            SetDescription(description) ;
            SetWeight(weight) ;
            SetDeliveryFee (deliveryFee) ;
            SetDestination(destination);

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
        //GetDescription
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
        //Weight
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
        //DeliveryFee
        public double GetDeliveryFee()
        {
            return DeliveryFee;
        }
        private void SetDeliveryFee(double value)
        {
            if (value > 0)
            {
                DeliveryFee = value;
            }
        }
        //Destination
        public DeliveryAddress GetDestination()
        {
            return Destination;
        }
         public void SetDestination(DeliveryAddress value)
        {
                Destination = value;
        }

        // EstimatedCost 

        public double EstimatedCost ()
        {
            return ( DeliveryFee + (Weight * 5) )  ;
        }

    }
}
