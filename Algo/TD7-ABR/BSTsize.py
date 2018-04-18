class BinTreeSize:
    def __init__(self, key, left, right, size):
        self.key = key
        self.left = left
        self.right = right
        self.size = size


#------------------------------------------------------------------------------
#  exercise 0: copyWithSize (in binary tree tuto)

def __addSize(B):
    if B == None:
        return(None, 0)
    else:
        C = BinTreeSize(B.key, None, None, 1)
        (C.left, size1) = __addSize(B.left)
        (C.right, size2) = __addSize(B.right)
        C.size += size1 + size2
        return (C, C.size)        

def __addSize2(B):
    if B == None:
        return(None, 0)
    else:
        (left, size1) = __addSize2(B.left)
        (right, size2) = __addSize2(B.right)
        size = 1 + size1 + size2
        return (BinTreeSize(B.key, left, right, size), size)
                
def copyWithSize(B):
    (C, size) = __addSize(B)
    return C
    
#------------------------------------------------------------------------------
#  leaf insertion
    
    # Final version
    
def addBSTSize_(A, x):
    if A == None:
        A = BinTreeSize(x, None, None, 1)
    else:
        if x <= A.key:
            A.left = addBSTSize_(A.left, x)
        else:
            A.right = addBSTSize_(A.right, x)
        A.size += 1
    return A
    

    # Tutorial version: x not inserted if already in B
    
def __addBSTSize(x, A):
    """
    return (bintree, booelan)
    boolean: boolean: is the insertion occurred?
    """
    if A == None:
        return (BinTreeSize(x, None, None, 1), True)
    else:
        if x <= A.key:
            (A.left, inserted) = __addBSTSize(x, A.left)
        else:
            (A.right, inserted) = __addBSTSize(x, A.right)
        if inserted:
            A.size += 1
        return (A, inserted)

def addBSTSize(B, x):
    (B, _) = __addBSTSize(x, B)
    return B
    
    
# median
        
def nthBST(B, k):
    if B.left == None:
        leftSize = 0
    else:
        leftSize = B.left.size
        
    if leftSize == k - 1:
        return B
    elif k <= leftSize:
        return nthBST(B.left, k)
    else:
        return nthBST(B.right, k - leftSize - 1)

def nthBST2(B, k):
    if B.left == None:
        if k == 1:
            return B
        else:
            return nthBST2(B.right, k - 1)
    else:
        if k == B.left.size + 1:
            return B
        elif k <= B.left.size:
            return nthBST2(B.left, k)
        else:
            return nthBST2(B.right, k - B.left.size - 1)        
            
            
def median(B):
    if B!= None:
        return nthBST(B, (B.size+1) // 2).key
    else:
        return None




    
    

