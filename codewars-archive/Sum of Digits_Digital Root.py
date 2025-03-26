def digital_root(n):
    final = 0
    for a in range(len(str(n))): final += int(str(n)[a])
    if len(str(final)) > 1: final = digital_root(final)
    return final
