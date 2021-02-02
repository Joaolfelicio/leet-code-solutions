/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) 
    {
        var dummyHead = new ListNode();
        var current = dummyHead;
        
        var sortedDict = new SortedDictionary<int, LinkedList<int>>();
        
        for(int i = 0; i < lists.Length; i++)
        {
            if(lists[i] != null) AddItem(sortedDict, lists[i].val, i);
        }
        
        while(sortedDict.Count > 0)
        {
            var smallestIndex = GetItemIndex(sortedDict);
            
            current.next = lists[smallestIndex];
            
            lists[smallestIndex] = lists[smallestIndex].next;
            
            if(lists[smallestIndex] != null) AddItem(sortedDict, lists[smallestIndex].val, smallestIndex);
            
            current = current.next;
        }
        
        return dummyHead.next;
    }
    
    private void AddItem(SortedDictionary<int, LinkedList<int>> dict, int value, int index)
    {
        if(dict.ContainsKey(value))
        {
            dict[value].AddLast(index);
        }
        else
        {
            dict.Add(value, new LinkedList<int>());
            dict[value].AddLast(index);
        }  
    }
    
    private int GetItemIndex(SortedDictionary<int, LinkedList<int>> dict)
    {
        var first = dict.Keys.First();
        
        var listIndex = dict[first];
        var item = listIndex.First();
        
        if(listIndex.Count > 1)
        {
            listIndex.RemoveFirst();
        }
        else
        {
            dict.Remove(first);
        }
        return item;
    }
}