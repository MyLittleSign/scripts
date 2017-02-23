using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class LetterButton : MonoBehaviour
{
	/* Cada botão que leva a uma cena de aprendizado de letras tem uma name contendo a letra dele.
	 * Exemplo de name: "Learn_g"
	 * O atual script será anexado a um botão, e através de sua name, reconhecerá a letra com a qual deve trabalhar.
	 * Após reconhecer a letra, obterá todas as informações necessárias ao botão:
	 *   - Disponível ou não ao usuário.
	 * Após descobrir se está disponível ou não, este script altera a imagem do botão para a disponibilidade ficar
	 * aparente.
	 */

	private string letter;

	// s_enabled contém a string necessária para acesso através do PlayerPrefs
	// enabled informará se a letra atual está disponível para aprendizado ou não
	private string s_enabled;
	private int enabled;
	private string alphabet = "abcdefghijklmnopqrstuvwxyz";

	private void Awake ()
	{
		string name = gameObject.name;
		letter = name.Substring (name.Length - 1);

		s_enabled = String.Concat ("enabled_", letter);

		if (!PlayerPrefs.HasKey (s_enabled))
		{
			if (letter == "a") 
			{
				PlayerPrefs.SetInt (s_enabled, 1);
			}
			else
			{
				PlayerPrefs.SetInt (s_enabled, 0);
			}
		}
		else
		{
			enabled = PlayerPrefs.GetInt (s_enabled);
		}
	}

	public void UpdateAppearance ()
	{
		if (enabled == 1)
		{
			this.GetComponent <Button> ().interactable = true;
		}
		else
		{
			this.GetComponent <Button> ().interactable = false;
		}
	}

	public void Done ()
	{
		if (letter != "z")
		{
			string next_letter = alphabet [alphabet.IndexOf (letter) + 1].ToString ();
			string new_enabled = String.Concat ("enabled_", next_letter);

			PlayerPrefs.SetInt (new_enabled, 1);
		}
	}
}
