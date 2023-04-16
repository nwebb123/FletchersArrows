using FletchersArrows.Enum;
using System.ComponentModel.DataAnnotations;

namespace FletchersArrows
{
    public class Arrow
    {
        public string _arrowhead;
        //public ArrowheadType TypeOfArrowhead;

        [MinLength(60), MaxLength(100)]
        public int _shaftLength;

        public string _fletching;

        public Arrow(string arrowhead, int shaftLength, string fletching)
        {
            _arrowhead = arrowhead;
            _fletching = fletching;
            _shaftLength = shaftLength;
        }


        public double CostPerArrow(Arrow customArrow)
        {
            //double cost = 0;
            double arrowheadCost = 0;
            double shaftCost = 0;
            double fletchingCost = 0;

            //Calculate Arrowhead cost
            switch (customArrow._arrowhead)
            {
                case "wood":
                    arrowheadCost = 3;
                    break;
                case "obsidian":
                    arrowheadCost = 5;
                    break;
                case "steel":
                    arrowheadCost = 10;
                    break;
                default:
                    arrowheadCost = -1;
                    break;
            }

            //Calculate shaft cost
            shaftCost = .05 * customArrow._shaftLength;

            //Calculate fletching cost
            switch (customArrow._fletching)
            {
                case "goose feathers":
                    fletchingCost = 3;
                    break;
                case "turkey feathers":
                    fletchingCost = 5;
                    break;
                case "plastic":
                    fletchingCost = 10;
                    break;
                default:
                    fletchingCost = -10999;
                    break;
            }

            
            return arrowheadCost + shaftCost + fletchingCost;

        }

    }

}
