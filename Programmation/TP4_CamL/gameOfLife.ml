(************************************************************)
(*                     Game of life                         *)
(************************************************************)

(* graphics *)

#load "graphics.cma" ;;
open Graphics ;;

let open_window size =
  open_graph(" " ^ string_of_int size ^ "x" ^ string_of_int (size+20));;

let grey = rgb 127 127 127 ;;

let cell_color = function
  | 0 -> white
  | _ -> black ;;

let cell_size = 10 ;;

(* original game of life definitions *)

let new_cell = 1 ;;

let empty = 0 ;;

let is_alive cell = cell <> empty ;;


(*******************   FROM TP 3 *********************)
(*   insert here needed simple functions on lists    *)




(*******************   Toolbox *********************)
(*             list list functions                 *)




(************************************************************)
(*                  graphics                                *)
(*        from the board to the graphic window              *)



(************************************************************)
(*                     Game of life                         *)
(************************************************************)



