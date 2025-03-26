def to_camel_case(text):
    final = ""
    i = 0
    while i in range(len(text)):
        if text[i] == "_" or text[i] == "-":
            final += text[i+1].capitalize()
            i += 2
        else:
            final += text[i]
            i += 1
    return final