using System;

/**
 * AbstractGirl
 * I'm not sure how I feel about the implication of treating women like Objects...
 */
public abstract class AbstractGirl
{
    private static int KISS_ROLL_REQ = 15; //Can't make it too easy!

    private bool isHot;
    public bool IsHot {
        get { return isHot; }
        protected set {
            if (!value) { throw new SelfLoveException(); }
            isHot = value;
        }
    }

    public float FullnessPercentage { get; protected set; }
    public long Monies { get; protected set; } //Could have made this an int, but why not be optimistic? Who says you won't reach max int monies and beyond!

    public AbstractDateLocation Location { get; set; }

    public abstract void Smooch(Harry harry);

    public AbstractGirl(bool isHot, float fullnessPercentage, long monies)
    {
        IsHot = isHot;
        FullnessPercentage = fullnessPercentage;
        Monies = monies;
    }

    public void Feed(float portionSize)
    {
        FullnessPercentage += portionSize;
        FullnessPercentage = Math.Min(FullnessPercentage, 1f); //Can't be more than 100% full!
    }

    public void Spend(long monies)
    {
        Monies -= monies;
    }

    public bool WillKiss()
    {
        //roll a d20, of course
        int roll = d20.Roll();

        return roll >= KISS_ROLL_REQ;
    }

    public bool WillStayTheNight()
    {
        int roll = d20.Roll();
        float rollPercentage = roll / 20f;

        //Chance to stay the night get's higher as get fuller, and so reverse is true
        float goHomeChance = (1f - FullnessPercentage);

        return rollPercentage > goHomeChance;
    }
}