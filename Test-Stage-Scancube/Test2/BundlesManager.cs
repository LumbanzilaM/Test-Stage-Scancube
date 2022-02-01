using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Stage_Scancube.Test1;

namespace Test_Stage_Scancube.Test2
{
    public class BundlesManager
    {

        public BundlesManager()
        {
            CreateBundles();
        }

        public void CreateBundles()
        {
            Bundles = new List<Bundle>()
            {
                CreateBundle("Carrefour"),
                CreateBundle("Auchan"),
                CreateBundle("Louis Vuitton"),
                CreateBundle("Patek"),
                CreateBundle("Bleu Ebène"),
                CreateBundle("Canon"),
                CreateBundle("Amazon"),
                CreateBundle("Celio"),
                CreateBundle("Maison du monde"),
                CreateBundle("Micromania")
            };
        }


        public List<Bundle> Bundles { get; set; }


        public Bundle CreateBundle(string owner)
        {
            // Votre code ici
            return null;
            //

        }


        /// <summary>
        /// Retourne le bundle du client (owner)
        /// </summary>
        /// <param name="owner">nom du client</param>
        /// <returns></returns>
        public Bundle GetBundleByOwner(string owner)
        {
            // Votre code ici
            return null;
            //
        }

        /// <summary>
        /// Retournes tous les clients connus
        /// </summary>
        /// <returns></returns>
        public List<string> GetOwners()
        {
            //Votre code ici

            return new List<string>();

            //
        }

    }
}
