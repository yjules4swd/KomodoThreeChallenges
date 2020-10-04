 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using KomodoBadges_Repository;
namespace KomodoBadges
{
    class Badges
    {
        int badgeId;
        List<string> doorname = new List<string>();
        // string badgeName;
        int doorNumber = 0;
        BadgesRepository MyBadges = new BadgesRepository();
        public void createNewBadge()
        {
            Console.WriteLine("What is the number on the badge");
            badgeId = int.Parse(Console.ReadLine());
            Console.WriteLine("List a door that it needs access to");
            string dooraccess = Console.ReadLine();
            doorname.Add(dooraccess);


            // MyBadges.Badges.Add(badgeId,dooraccess);
            
            Console.WriteLine("Any other doors(y/n)?");
            string response = Console.ReadLine();
            while(response != "n")
            {
                Console.WriteLine("List a door that it needs access to");
                dooraccess = Console.ReadLine();
                // MyBadges.Badges.Add(badgeId, dooraccess);
                doorname.Add(dooraccess);
                Console.WriteLine("Any other doors(y/n)?");
                response = Console.ReadLine();
            }
            if(response=="n")
            {
                MyBadges.Badges.Add(badgeId, doorname);
                Console.WriteLine("return to main nenu");
            }
        }

        public void listAllBadges()
        {
          foreach(var myaccess in MyBadges.Badges.Keys)
            {
                foreach(var Listchild in MyBadges.Badges[myaccess])
                {
                    Console.WriteLine("Badge: " + myaccess + " Door: " + Listchild);
                }
            }
        }

        public void editBadge()
        {
            Console.WriteLine("What is the badge number to update?");
            string userresponse = Console.ReadLine();
            Console.WriteLine("{0} has access to doors", );
            Console.WriteLine("What would you like to do?\n1. Remove a door\n2. Add a door");
        }

        void removeADoor()
        {

        }

        void addadoor()
        {

        }

        // Creating properties to be used outside the class
        public int _badgId
        {
            get
            {
                return badgeId;
            }
            set
            {
                badgeId = value;
            }
        }
        
            // Creating properties to be used outside the class

       
        public List<string> _doorname
        {
            get
            {
                return doorname;
            }
            set
            {
                doorname = value;
            }
        }
    }
}
