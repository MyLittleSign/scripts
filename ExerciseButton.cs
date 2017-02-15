﻿using UnityEngine;
using System.Collections;
using System;

public class ExerciseButton : MonoBehaviour
{
	/* Cada botão que leva a uma cena de exercício tem uma tag informando quais letras serão abordadas
	 * Exemplo de tag: "abc"
	 * 
	 * O atual script será anexado a um botão, e através de sua tag, reconhecerá a letra com a qual deve trabalhar.
	 * 
	 * Após reconhecer as letras, obterá todas as informações necessárias ao botão:
	 *   - Disponível ou não ao usuário.
	 *   - Quantidade de estrelas ganhas
	*/

	private string letters;

	// s_step contém a string necessária para acesso através do PlayerPrefs
	// step é um valor entre -1 e 3
	// -1 = indisponível
	// 0..3 = quantidade de estrelas
	private string s_step;
	private int step;

	private void Awake ()
	{
		letters = this.gameObject.tag;
		s_step = String.Concat ("step_", letters);
		step = PlayerPrefs.GetInt (s_step);
	}
}