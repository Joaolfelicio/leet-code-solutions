public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        if(string.IsNullOrWhiteSpace(version1) && string.IsNullOrWhiteSpace(version2)) return 0;
        if(string.IsNullOrWhiteSpace(version2)) return 1;
        if(string.IsNullOrWhiteSpace(version1)) return -1;

        var p1 = 0;
        var p2 = 0;

        while(p1 < version1.Length || p2 < version2.Length)
        {
            var r1 = GetRevision(version1, p1);
            var r2 = GetRevision(version2, p2);

            Int32.TryParse(r1, out var r1Int);
            Int32.TryParse(r2, out var r2Int);

            if(r1Int > r2Int) return 1;
            else if(r1Int < r2Int) return -1;

            p1 += r1.Length + 1;
            p2 += r2.Length + 1;
        }
        return 0;
    }

    private string GetRevision(string version, int index)
    {
        if(index >= version.Length) return "0";

        var pointer = index;
        var length = 0;

        while(pointer < version.Length && version[pointer++] != '.') length++;

        return version.Substring(index, length);
    }
}
