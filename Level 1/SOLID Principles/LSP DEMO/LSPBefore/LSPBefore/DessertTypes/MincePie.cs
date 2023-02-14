namespace LSPBefore.DessertTypes
{
    public class MincePie: Dessert
    {
        public override void CalculateCalories(int grams)
        {
            Console.WriteLine("Total calories " + grams * 25);
        }

        //Pie cannot melt at room temperature because it can be served as hot
        public override void GetRoomTemperatureMeltingPoint()
        {
            throw new NotSupportedException("Pie doesn't have room temperature melting point");
        }
    }
}
