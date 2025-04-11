using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Stage_Scancube.Test1;
using Test_Stage_Scancube.Test2;

namespace Test_Stage_Scancube.Test2
{
    public class BundlesManager
    {

        public BundlesManager()
        {
            CreateBundles();
        }


        public List<Bundle> Bundles { get; set; } = new List<Bundle>();


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


        /// <summary>
        /// Créer un bundle qui a pour client le paramètre owner
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public Bundle CreateBundle(string owner)
        {
            return new Bundle(owner);
            //

        }


        /// <summary>
        /// Retourne le bundle du client (owner)
        /// </summary>
        /// <param name="owner">nom du client</param>
        /// <returns></returns>
        public Bundle GetBundleByOwner(string owner)
        {
            
            return Bundles.Find(x => x.Owner == owner);
            //
        }

        /// <summary>
        /// Retournes tous les clients connus
        /// </summary>
        /// <returns></returns>
        public List<string> GetOwners()
        {
            List<string> owners = new List<string>();
            owners.AddRange(Bundles.Select(x => x.Owner).ToList());
            return owners;

            //
        }

    }
}
