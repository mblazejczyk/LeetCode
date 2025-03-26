#https://www.codewars.com/kata/52742f58faf5485cae000b9a/python
def format_duration(seconds):
    if seconds == 0:
        return "now"

    y = seconds // 31536000
    d = (seconds // 86400) % 365
    h = (seconds // 3600) % 24
    m = (seconds // 60) % 60
    s = seconds % 60
    rStr = ""

    if y > 0:
        rStr += f"{y} year" if y == 1 else f"{y} years"

    if d > 0:
        if rStr:
            rStr += ", "
        rStr += f"{d} day" if d == 1 else f"{d} days"

    if h > 0:
        if rStr:
            rStr += ", "
        rStr += f"{h} hour" if h == 1 else f"{h} hours"

    if m > 0:
        if rStr:
            if s > 0:
                rStr += ", "
            else:
                rStr += " and "
        rStr += f"{m} minute" if m == 1 else f"{m} minutes"

    if s > 0:
        if rStr:
            rStr += " and "
        rStr += f"{s} second" if s == 1 else f"{s} seconds"

    return rStr
