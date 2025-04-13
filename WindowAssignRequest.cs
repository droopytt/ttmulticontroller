namespace TTMulti
{
    internal class WindowAssignRequest
    {
        public int GroupNumber { get; }
        public int HWnd { get; }
        public PairDirection Pair { get; }

        public WindowAssignRequest(int groupNumber, int hWnd, PairDirection pair)
        {
            GroupNumber = groupNumber;
            HWnd = hWnd;
            Pair = pair;
        }
    }
}
