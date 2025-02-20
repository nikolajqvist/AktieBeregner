using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AktieBeregner
{
    /// <summary>
    /// Aktie klasse.
    /// </summary>
    public class Share
    {
        /// <summary>
        /// Navnet på aktien
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Antal aktier
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// Salgspris på aktien nu
        /// </summary>
        public int SellPrice { get; set; }
        /// <summary>
        /// købs prisen på aktien
        /// </summary>
        public int BuyPrice { get; set; }
        /// <summary>
        /// Valutaen af aktie kurs
        /// </summary>
        public int Currency { get; set; }
        /// <summary>
        /// Construktør som aktien bliver født
        /// </summary>
        /// <param name="name"></param>
        /// <param name="amount"></param>
        /// <param name="buyprice"></param>
        /// <param name="sellprice"></param>
        public Share(string name, int amount, int buyprice, int sellprice)
        {
            Name = name;
            Amount = amount;
            BuyPrice = buyprice;
            SellPrice = sellprice;
        }
        /// <summary>
        /// Udregning af afkastet af aktie
        /// </summary>
        /// <returns></returns>
        public int ReturnValue()
        {
            return (SellPrice - BuyPrice) * Amount;
        }
    }
}
