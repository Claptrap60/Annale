(************************************************************)
(*                 Higher Order Functions                   *)
(************************************************************)

(*****************     Toolbox   *******************)
(*                 Char and String                 *)


(*                   Higher Order                  *)


(*****************     Cipher    *******************)
(*                  Ceasar Cipher                  *)

(*                 Vigenere Cipher                 *)

(*****************  Build House  *******************)

let sand = ['B' ; 'b' ; 'L' ; 'r' ; 'B'; 'B' ; '\n'];;
let water = ['y' ; 'o' ; 'y' ; 'y' ; 'i'; 'y'; '\n'];;
let brick = ['y' ; 's' ; 's' ; 's' ; 's'; 'e'; '\n'];;
let wood = ['h' ; 'r' ; 'w' ; 'w' ; 'r'; 'h'; '\n'];;
let coca = ['s' ; 'l' ; 'r' ; 'x' ; 'l'; 's'; '\n'];;

let house = [sand ; water ; brick ; wood ; coca];;

let workers = [lowercase ; swap_alpha ; rot13 ; rotn 5 ; rotn 20];;
