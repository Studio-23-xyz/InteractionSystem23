namespace com.studio23.ss2.InteractionSystem23.Data
{
    public enum InteractionState{
        Inactive,//interaction hasn't started yet.
        Active,//runing interaction logic
        Paused,// running a sub-interaction or some other case when we don't want the interaction to run logic
    }
}