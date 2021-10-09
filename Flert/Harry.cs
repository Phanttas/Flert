public class Harry
{
    private AbstractDateLocation home = new HarrysPlace();

    public void TakeOnDate(AbstractGirl girl, AbstractDateLocation location)
    {
        //Girl goes to date location
        girl.Location = location;

        //Eats food
        girl.Feed(location.PortionSize);

        //Pays for bill, but eats for free if hot
        if (!girl.IsHot)
        {
            //Split the bill
            long shareToPay = location.MoniesCost / 2;
            girl.Spend(shareToPay);
        }

        //How well did it go?
        if (girl.WillKiss())
        {
            girl.Smooch(this);
        }

        if (girl.WillStayTheNight())
        {
            girl.Location = home;
        }
    }

    private class HarrysPlace : AbstractDateLocation
    {
        public override long MoniesCost => 0;
        public override float PortionSize => 0.6f;
    }
}