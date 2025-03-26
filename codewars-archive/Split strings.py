#Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').
#Examples:
#* 'abc' =>  ['ab', 'c_']
#* 'abcdef' => ['ab', 'cd', 'ef']

def solution(s):
    output = []
    x = 0
    while x < len(s):
        if len(s) > x + 1:
            output.append(str(s[x]) + str(s[x + 1]))
        else:
            output.append(str(s[x]) + "_")
        x += 2
    return output