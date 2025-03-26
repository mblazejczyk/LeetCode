#https://www.codewars.com/kata/52c4dd683bfd3b434c000292
def is_interesting(number, awesome_phrases):
    if number < 98:
        return 0
    if number == 98 or number == 99:
        return 1
    # zeros
    for i in range(len(str(number))):
        if i == 0:
            continue
        if str(number)[i] != "0":
            break
        if len(str(number)) - 1 == i:
            return 2

    # all same
    n = str(number)[0]
    for i in range(len(str(number))):
        if str(number)[i] != n:
            break
        if len(str(number)) == i:
            return 2

    #inc
    num_str = str(number)
    for i in range(len(num_str)):
        if i == len(num_str) - 1:
            return 2
        if int(num_str[i]) == 9 and int(num_str[i + 1]) == 0:
            return 2
        if int(num_str[i + 1]) != int(num_str[i]) + 1:
            break

    #dec
    for i in range(len(num_str)):
        if i == len(num_str) - 1:
            return 2
        if int(num_str[i + 1]) != int(num_str[i]) - 1:
            break

    # plindrome
    num_str = str(number)
    if num_str == num_str[::-1]:
        return 2  # Palindrome

    # awesome
    for i in range(len(awesome_phrases)):
        if number == awesome_phrases[i]:
            return 2
    if len(awesome_phrases) > 0 and awesome_phrases[len(awesome_phrases)-1] == "recur":
        return 0
    ph = awesome_phrases
    ph.append("recur")

    # check next
    if is_interesting(number + 1, ph) == 2 or is_interesting(number + 2, ph) == 2:
        return 1
    else:
        return 0
