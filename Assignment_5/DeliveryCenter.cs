using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public struct DeliveryCenter
    {
        private Shipment[] _shipments;

        public DeliveryCenter()
        {
            _shipments = new Shipment[10];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < 10)
                    return _shipments[index];

                return default;
            }
            set
            {
                if (index >= 0 && index < 10)
                    _shipments[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < 10; i++)
                {
                    if (_shipments[i].TrackingCode == trackingCode)
                        return _shipments[i];
                }
                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < 10; i++)
            {
                if (_shipments[i].TrackingCode == null)
                {
                    _shipments[i] = shipment; 
                    return true; 
                }
            }
            return false;
        }
    }
}
