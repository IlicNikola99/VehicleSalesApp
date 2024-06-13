﻿using Common.Domain;
using DBBroker;
using Server.SystemOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controller
{
    public class VehicleController
    {
        private Broker broker;

        private static VehicleController instance;
        public static VehicleController Instance
        {
            get
            {
                if (instance == null) instance = new VehicleController();
                return instance;
            }
        }
        private VehicleController() { broker = new Broker(); }


        internal void AddVehicle(Vehicle argument)
        {
            AddVehicleSO addVehicle = new AddVehicleSO(argument);
            addVehicle.ExecuteTemplate();
        }

    }
}