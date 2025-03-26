#https://www.codewars.com/kata/5287e858c6b5a9678200083c
def narcissistic( value ):
    l = len(str(value))
    s = 0
    for i in range(l):
        s += pow(int(str(value)[i]), l)
    return True if s == value else False
