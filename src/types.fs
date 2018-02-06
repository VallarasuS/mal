﻿module Make.A.Lisp.Types

open System

type Type =
    | Nil
    | Ture
    | False
    | String of string
    | Number of int
    | Symbol of string
    | Undefined of string
    | Lst of Type list
    | Func of (Type list -> int)

 type Env = System.Collections.Generic.Dictionary<string,Type>