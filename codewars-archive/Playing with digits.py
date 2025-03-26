#https://www.codewars.com/kata/5552101f47fc5178b1000050
def dig_pow(n, p):
    s = len(str(n))
    p2 = p
    l = 0
    for i in range(s):
        l += pow(int(str(n)[i]), p2)
        p2 += 1
    k = l / n
    return -1 if int(k) != k else k
