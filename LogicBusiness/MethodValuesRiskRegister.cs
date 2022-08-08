using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazard_Automation.LogicBusiness
{
    public class  MethodValuesRiskRegister
    {
    
    

        public List<string> par = new List<string>();
        public List<string> parameters = new List<string> { "Health and Safety Risk Associated with the Activities", "Fatal Risk Category", "GENERIC CONTROL MEASURES" };


        public List<string> values_windows = new List<string> { "Work at Height, Lifting Operations, Noise, Vibration, Dropped Objects, Dust",
                                         "Working at height, Lifting, Health",
                                           "Ensure leading edge is protected, use of lanyards and fall preverntion and fall protection hierichy eliminating risk of falls. Dropped object control - tool tenthering. Checks on lifting accessories, planned and authorised lift plan, exclusion zones, competent persons, noise control areas, screens, engineering controls such as dampners, hearing protection, health surveilance, Enginnering controls within the vehicle such as vibration dampners, eliminating hand tools that cause vibration to the hand. Elimnating the need to cut concrete or timber by off site manufacture, re useable materials / moulds etc, PPE last reoort, tools to manage dust creation and capture of dust, no brooms!" };
        public List<string> values_doors = new List<string> { "Fire - making sure fire does not spread during construction, manual handling",
                "Catastrophic risk, Health",
                "Fire risk assessment in place that considers risk of fire as building is constructed - temporary compartmentalisation. Mechanical aids, lightweght materials - alternatives say off site manufacued panels" };

        public List<string> values_piles = new List<string> { "Fire - making sure fire does not spread during construction, manual handling",
                "Catastrophic risk, Health",
                "Fire risk assessment in place that considers risk of fire as building is constructed - temporary compartmentalisation. Mechanical aids, lightweght materials - alternatives say off site manufacued panels" };


    }
}
