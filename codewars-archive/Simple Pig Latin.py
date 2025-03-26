def pig_it(text):
    ar = text.split(' ')
    final = ""
    for i in range(len(ar)):
        if ar[i] == "!" or ar[i] == "?": 
            final += ar[i] + " "
            break
        final += ar[i][1:] + ar[i][0] + "ay "
    return final[:-1]