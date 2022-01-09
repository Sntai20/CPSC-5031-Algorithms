import random
import statistics

def selection_sort(a):
    """Instrumented selection sort. Returns number of comparisons made.
    see Levitin, p. 99
    """
    comparisons = 0
    for i in range(len(a)-1):
        min = i
        for j in range(i+1, len(a)):
            comparisons += 1
            if a[min] > a[j]:
                min = j
        a[i], a[min] = a[min], a[i]  # swap
    return comparisons

def quick_sort(a, l=0, r=None):
    """Instrumented quick sort. Returns number of comparisons made.
    see Levitin, p. 176
    """
    if r is None:
        r = len(a) - 1
    if l >= r:
        return 0
    comparisons = r - l  # Lomuto compares every other element against first
    s = lomuto_partition(a, l, r)
    comparisons += quick_sort(a, l, s-1)
    comparisons += quick_sort(a, s+1, r)
    return comparisons

def lomuto_partition(a, l, r):
    """LomutoPartition from Levitin, p. 159 
    Partitions subarray by Lomuto's algorithmm using first element as pivot
    Input: A subarray a[l..r] of array a[0..n-1], l <= r
    Output: Partition of a[l..r] and the new position of the pivot
    """
    p = a[l]
    s = l  # s is the end of the less-than-pivot section
    for i in range(l+1, r+1):
        if a[i] < p:
            s += 1
            a[s], a[i] = a[i], a[s]
    a[l], a[s] = a[s], a[l]
    return s

def random_seq(n=10, lo=0, hi=100):
    """ Make a list of random integers of given length. """
    seq = []
    for i in range(n):
        seq.append(random.randint(lo, hi))
    return seq

if __name__ == '__main__':
    n = 29
    print('n:', n)

    a = random_seq(n)
    print('SelectionSort:', selection_sort(a))
    #print(a)

    data = []
    for i in range(10000):
        a = random_seq(n)
        comps = quick_sort(a)
        #print('QuickSort:', comps)
        data.append(comps)
        #print(a)
    print('QuickSort:', statistics.mean(data))


#========================================================== 
#  OUTPUT
#========================================================== 
#  n: 29
#  SelectionSort: 406
#  QuickSort: 121.7143
#
#  Press any key to continue . . .