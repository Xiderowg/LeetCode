class Solution:
    def restoreIpAddresses(self, s: str) -> List[str]:
        n,ret=len(s),[]
        def dfs(m:List[str],start:int):
            if len(m)==4:
                if start==n:
                    ret.append('.'.join(m))
                return
            for i in range(1,4):
                if i+start>n:
                    return
                if s[start]=='0' and i>1:
                    return
                if int(s[start:i+start])>255:
                    return
                m.append(s[start:i+start])
                dfs(m,start+i)
                m.pop()
        dfs([],0)
        return ret

    