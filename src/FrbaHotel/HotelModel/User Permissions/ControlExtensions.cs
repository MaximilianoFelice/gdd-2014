﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.User_Permissions.UFR;
using HotelModel.User_Permissions.Exceptions;

namespace HotelModel.User_Permissions
{
    public static class ControlExtensions
    {
        public static void HandleVisibility(this Control ctrl)
        {
            PermissionManager.addVisibleControl(ctrl);
        }

        public static void HandleAccess(this Control ctrl)
        {
            PermissionManager.addAccessibleControl(ctrl);
        }

        public static void VisibleBy(this Control ctrl, String feature)
        {
            try
            {
                Feature.getFeaturesDictionary[feature].CanView(ctrl);
            } catch{
                throw new FeatureNotFoundException("Feature " + feature + " was not found");
            }
        }

        public static void AccesedBy(this Control ctrl, String feature)
        {
            try
            {
                Feature.getFeaturesDictionary[feature].CanView(ctrl);
            } catch{
                throw new FeatureNotFoundException("Feature " + feature + " was not found");
            }
        }

        public static void VisibleBy(this Control ctrl, Feature feat)
        {
            feat.CanView(ctrl);
        }

        public static void AccesedBy(this Control ctrl, Feature feat)
        {
            feat.CanView(ctrl);
        }
    }
}
