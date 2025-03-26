#https://www.codewars.com/kata/51ba717bb08c1cd60f00002f
def solution(args):
    output = ""
    i = 0
    tmp = []
    while i < len(args):
        if len(tmp) > 0:
            if tmp[1] == args[i] - 1:
                tmp[1] = args[i]
                i += 1
                continue
            else:
                output += "," + str(tmp[0]) + "-" + str(tmp[1])
                tmp.pop(0)
                tmp.pop(0)
        if len(args) - i > 2 and args[i] == args[i + 1] - 1 and args[i] == args[i + 2] - 2:
            tmp.append(args[i])
            tmp.append(args[i + 2])
            i += 3
            continue
        else:
            output += "," + str(args[i])
            i += 1
    if len(tmp) > 0:
        output += "," + str(tmp[0]) + "-" + str(tmp[1])
    return output[1:]
