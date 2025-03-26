#https://www.codewars.com/kata/52685f7382004e774f0001f7/python
def make_readable(seconds):
    h = int(seconds/3600)
    m = int(seconds/60 - h*60)
    s = int(seconds - h*3600 - m*60)
    return f"{h:02}:{m:02}:{s:02}"
