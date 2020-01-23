using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given two Dictionaries, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2,
         * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
         *
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *
         * ConsolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         *
         */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> mainWarehouse,
            Dictionary<string, int> remoteWarehouse)
        {
            Dictionary<string, int> mergedDictionary = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> inventoryMain in mainWarehouse)
            {
                mergedDictionary[inventoryMain.Key] = inventoryMain.Value;
                foreach (KeyValuePair<string, int> inventoryRemote in remoteWarehouse)
                {
                    if (inventoryMain.Key.Equals(inventoryRemote.Key))
                    {
                        mergedDictionary[inventoryMain.Key] = inventoryMain.Value + inventoryRemote.Value;
                    }
                    else if (!mergedDictionary.ContainsKey(inventoryRemote.Key))
                    {
                        mergedDictionary[inventoryRemote.Key] = inventoryRemote.Value;
                    }
                    
                    
                }
            }






            /*

                foreach (string key1 in mainWarehouse.Keys)
            {
                mergedDictionary[key1] = mainWarehouse[key1];

                foreach (string key2 in remoteWarehouse.Keys)
                {
                    
                    if (key1 == key2)
                    {
                        
                        mergedDictionary[key1] = (mainWarehouse[key1] + remoteWarehouse[key2]);
                    }
                    else
                    {
                        
                        mergedDictionary[key2] = remoteWarehouse[key2];
                    }
                   


                }
                
            }
            */


            return mergedDictionary;
        }
    }
}
