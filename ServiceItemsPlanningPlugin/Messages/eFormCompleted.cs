namespace ServiceItemsPlanningPlugin.Messages
{
    public class eFormCompleted
    {
        public int caseId { get; protected set; }

        public eFormCompleted(int caseId)
        {
            this.caseId = caseId;
        }
    }
}