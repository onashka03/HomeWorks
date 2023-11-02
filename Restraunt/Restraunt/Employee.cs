using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restraunt
{
  public  class Employee
    {
    int newRequestCount;
    public object newMenuItem;

    public Employee()
    {
        newRequestCount = 0;
       newMenuItem = null;
    }

    public object NewRequest(int quantity, string menuItem)
    {
        newRequestCount++;       
        if (newRequestCount % 3 == 0)
        {
          if (menuItem == "Chicken")
              menuItem = "EggOrder";
            else
              menuItem = "Chicken";
        }
        if (menuItem == "Chicken")
             newMenuItem = new ChickenOrder(quantity);
         else 
            newMenuItem = new EggOrder(quantity);

        return newMenuItem;
    }

    public object CopyRequest()
    {
        if (newMenuItem == null)
            throw new Exception("No request to copy. Please call NewRequest method first.");
        if (newMenuItem is ChickenOrder)
        {
            var chicken = newMenuItem as  ChickenOrder;
            return new ChickenOrder(chicken.GetQuantity());
        }
        if (newMenuItem is EggOrder)
        {
            var eggOrder = newMenuItem as  EggOrder;
            return new EggOrder(eggOrder.GetQuantity(), GetQuality());

            return null;
               
        }
        return "";
    }

    private int? GetQuality()
    {
        throw new NotImplementedException();
    }

    public string Inspect(object order)
    {
        if (order is ChickenOrder)
        {
            return "No inspection required for chicken order.";
        }
         else if (order is EggOrder)
        {
            var eggOrder = order as EggOrder;
            return eggOrder.GetQuality().ToString();          
       }
        else
        {
            return "Invalid order type.";
        }
    }
         public string PrepareFood(object order)
    {
        if (order is ChickenOrder)
        {
            ChickenOrder chickenOrder = (ChickenOrder)order;
            int quantity = chickenOrder.GetQuantity();

            for (int i = 0; i < quantity; i++)
            {
                chickenOrder.CutUp();
            }

            chickenOrder.Cook();

            return "Chicken preparation completed.";
        }
        else if (order is EggOrder)
        {
            EggOrder eggOrder = (EggOrder)order;
            int quantity = eggOrder.GetQuantity();
            int rottenEggs = 0;

            for (int i = 0; i < quantity; i++)
            {
                try
                {
                    eggOrder.Crack();
                }
                catch
                {
                    rottenEggs++;
                    continue;
                }
                finally
                {
                    eggOrder.DiscardShell();
                }
            }
            
            eggOrder.Cook();

            return "Egg preparation completed. Rotten eggs found: {rottenEggs}.";
        }
        else
        {
            return "Invalid order type.";
        }
              }
         }
    }
