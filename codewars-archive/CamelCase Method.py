#https://www.codewars.com/kata/587731fda577b3d1b0001196
def camel_case(s):
    otp = ""
    for i in range(len(s.split(' '))):
        otp += s.split(' ')[i].capitalize()
    return otp
