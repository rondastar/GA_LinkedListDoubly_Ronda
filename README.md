# GA_LinkedListDoubly_Ronda

Explanation of a doubly linked list and its utility.  
 - A doubly linked list has nodes that are linked by references to the nodes both before and after them. It can be traversed from front to back or back to front.

Comparisons between singly and doubly linked lists in terms of efficiency and use cases. 
 - Doubly linked lists are less efficient than singly in terms of memory because they have two reference pointers per node. However, doubly linked lists can be more efficient in terms of time, if nodes at the end or middle of the list need to be accessed often.

The significance of having two references in a node and potential issues. 
 - Having two references in a node enables the linked to be transversed in both directions, from front to back and back to front. One pitfall is that is can be easy to overlook updating a reference or to update it wrong, which could lead to incorrect links or lost data.

Discuss scenarios where a doubly linked list is preferable over a singly linked list or an array. 
 - A doubly linked list is preferably over a singly linked list when the list needs to be transversed in both directions. One example would be the undo and redo buttons in word processors, where data is added at the end but may need to be accessed in reverse or forward again. Both doubly and singly linked lists could be prefrable to arrays if the list is very dynamic and increases and decreases in size often.

Considerations for choosing between a doubly linked list and other data structures. 
 - If elements stay in sequence and it is helpful for the data to be accessed sequentially, or if the list is dynamic and has a fluctuating size, a doubly linked list could be a good choice. If the list is static or needs to be sorted and rearranged often, an array or list would be a better option.
	
Thoughts on combining the advantages of different data structures for optimal efficiency.
 - If there is sequential data that has static information, an array or class could be used to store the static details, and the linked list could be used to store the sequence. I've been trying to think of ways this could be used in a recipe app, and one idea would be to have a list of the most recently added recipes. 
