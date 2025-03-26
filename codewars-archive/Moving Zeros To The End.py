#https://www.codewars.com/kata/52597aa56021e91c93000cb0
def move_zeros(lst):
    for i in reversed(range(len(lst))):
        if lst[i] == 0:
            lst.pop(i)
            lst.append(0)
    return lst
