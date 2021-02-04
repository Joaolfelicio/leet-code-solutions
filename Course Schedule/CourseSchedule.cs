public class Solution 
{
    public bool CanFinish(int numCourses, int[][] prerequisites) 
    {
        // The course and its list of course dependencies
        var courseDict = BuildCourseGraph(prerequisites);
        
        var completed = new bool[numCourses];
        

        for(int i = 0; i < numCourses; i++)
        {
            var path = new bool[numCourses];

            if(IsCyclic(i, courseDict, completed, path)) 
                return false;
        }
        return true;
    }
    
    private bool IsCyclic(int currCourse, Dictionary<int, List<int>> courseDict, bool[] completed, bool[] path)
    {
        // If we already completed the course or it has no dependencies, it cant be a cyclic
        if(!courseDict.ContainsKey(currCourse) || completed[currCourse]) return false;

        // If in the current path we already found this course, it's a cycle
        if(path[currCourse]) return true;
        
        path[currCourse] = true;
        
        foreach(var dep in courseDict[currCourse])
        {
            if(IsCyclic(dep, courseDict, completed, path)) return true;
        }
        
        completed[currCourse] = true;
        
        return false;
    }

    
    private Dictionary<int, List<int>> BuildCourseGraph(int[][] prerequisites)
    {
        var courseDict = new Dictionary<int, List<int>>();
        
        // Build the graph
        foreach(var relation in prerequisites)
        {
            if(courseDict.ContainsKey(relation[1])) 
                courseDict[relation[1]].Add(relation[0]);
            else
                courseDict.Add(relation[1], new List<int>() {relation[0]});
        }
        
        return courseDict;
    }
}