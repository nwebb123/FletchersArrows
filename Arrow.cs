using System.ComponentModel.DataAnnotations;

namespace FletchersArrows
{
    public class Arrow
    {
        public string Arrowhead;

        [MinLength(60), MaxLength(100)]
        public int ShaftLength;

        public string Fletching;

        public Arrow(string fletching, string arrowhead, int shaftLength)
        {
            Fletching = fletching;
            ShaftLength = shaftLength;
            Arrowhead = arrowhead;
        }


        double CostPerArrow(Arrow customArrow)
        {
            double cost = 0;
      

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
