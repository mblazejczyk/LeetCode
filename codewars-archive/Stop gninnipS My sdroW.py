def spin_words(sentence):
    a = sentence.split()
    final = ""
    for i in range(len(a)):
        if len(a[i]) < 5:
            final += a[i] + " "
        else:
            final += a[i][::-1] + " "
    return final[:-1]