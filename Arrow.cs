using System.ComponentModel.DataAnnotations;

namespace FletchersArrows
{
    public class Arrow
    {
        public string Arrowhead;

        [MinLength(60), MaxLength(100)]
        public int ShaftLength;

        public string Fletching;

        public Arrow(string arrowhead, int shaftLength, string fletching)
        {
            Arrowhead = arrowhead;
            Fletching = fletching;
            ShaftLength = shaftLength;
        }


        public double CostPerArrow(Arrow customArrow)
        {
            double cost = 0;
            double arrowheadCost = 0;
            double shaftCost = 0;
            double fletchingCost = 0;

            //Calculate Arrowhead cost
            switch (customArrow.Arrowhead)
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
            shaftCost = .05 * customArrow.ShaftLength;

            //Calculate fletching cost
            switch (customArrow.Fletching)
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

            cost = arrowheadCost + shaftCost + fletchingCost;
            return cost;

        }



    }

    enum ArrowHeadMaterial
    {
        Wood,
        Steel,
        Obsidian
    }
    enum FletchingMaterial
    {
        Plastic,
        TurkeyFeathers,
        GooseFeathers
    }




}
