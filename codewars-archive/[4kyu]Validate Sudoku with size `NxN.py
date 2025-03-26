#https://www.codewars.com/kata/540afbe2dc9f615d5e000425/python
import math


class Sudoku(object):
    def __init__(self, data):
        self.data = data
        pass
    def is_valid(self):
        #size check
        d = len(self.data[0])
        l = len(self.data)
        sqr = math.sqrt(d)
        if d != l:
            return False

        ar = {}
        ar2 = {}
        for i in range(d):
            for j in range(d):
                if type(self.data[i][j]) is not int: #data type check
                    return False
                if self.data[i][j] > d: #i to N check
                    return False
                if self.data[i][j] <= 0: #i to N check
                    return False

                if self.data[i][j] in ar: #row check
                    ar[self.data[i][j]] += 1
                else:
                    ar[self.data[i][j]] = 1
                for x in ar:
                    if ar[x] > 1:
                        return False
                ar.clear()

                if self.data[j][i] in ar2: #column check
                    ar2[self.data[j][i]] += 1
                else:
                    ar2[self.data[j][i]] = 1
            for x in ar2:
                if ar2[x] > 1:
                    return False
            ar2.clear()

        #squares check
        ar = {}
        for i in range(int(sqr)):
            for j in range(i + int(sqr * i), int(sqr * (i + 1))):
                for k in range(i + int(sqr * i), int(sqr * (i + 1))):
                    if self.data[j][k] in ar:
                        ar[self.data[j][k]] += 1
                    else:
                        ar[self.data[j][k]] = 1
            for x in ar:
                if ar[x] > 1:
                    return False
            ar.clear()
        return True
