using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpecFlowProj.Support
{
    public class Consts
    {
        public const string BingMainPageURL = "http://bing.com";

        public const string SenselessText = "klajhsdkajhsfihuaisujhdkajshdkjahsdiasdihi";

        public const string MeaningfulText = "wave-particle duality";

        public static List<string> SearchResultsURLs = new List<string> 
        {
            "https://en.wikipedia.org/wiki/Wave%E2%80%93particle_duality",
            "https://www.thoughtco.com/wave-particle-duality-2699037",
            "https://www.youtube.com/watch?v=Q_h4IoPJXZw",
            "http://hyperphysics.phy-astr.gsu.edu/hbase/mod1.html",
            "https://www.youtube.com/watch?v=fAVPRDnzSpE",
            "https://www.sciencedaily.com/terms/wave-particle_duality.htm",
            "https://science.howstuffworks.com/light6.htm",
            "https://chem.libretexts.org/Bookshelves/Physical_and_Theoretical_Chemistry_Textbook_Maps/Supplemental_Modules_(Physical_and_Theoretical_Chemistry)/Quantum_Mechanics/09._The_Hydrogen_Atom/Atomic_Theory/Electrons_in_Atoms/Wave-Particle_Duality",
            "https://www.britannica.com/science/wave-particle-duality",
            "https://en.wikipedia.org/wiki/Wave-particle_duality_relation"
        };

        public static Dictionary<string, string> TextsInElements = new Dictionary<string, string>
        {
            {"Images", "Images"},
            {"SignIn", "Sign in"}
        };
    }
}
