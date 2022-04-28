/* 
* $Id$
*
*  Copyright (c) 2010, Novartis Institutes for BioMedical Research Inc.
*  All rights reserved.
* 
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are
* met: 
*
*     * Redistributions of source code must retain the above copyright 
*       notice, this list of conditions and the following disclaimer.
*     * Redistributions in binary form must reproduce the above
*       copyright notice, this list of conditions and the following 
*       disclaimer in the documentation and/or other materials provided 
*       with the distribution.
*     * Neither the name of Novartis Institutes for BioMedical Research Inc. 
*       nor the names of its contributors may be used to endorse or promote 
*       products derived from this software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
* "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
* LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
* A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
* OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
* SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
* LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
* DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
* THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
* (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
* OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

%{
#include <DataStructs/BitVect.h>
#include <DataStructs/ExplicitBitVect.h>
%}

#if SWIGCSHARP
%csmethodmodifiers ExplicitBitVect::ToString() const "public override";
#endif

%ignore ExplicitBitVect::dp_bits;
%ignore ExplicitBitVect::getOnBits (IntVect& v) const;
%ignore ExplicitBitVect::ExplicitBitVect(unsigned int,bool);

#ifdef SWIGJAVA

%template(UChar_Vect) std::vector<unsigned char>;
%typemap(jni) std::string ExplicitBitVect::toByteArray "jbyteArray"
%typemap(jtype) std::string ExplicitBitVect::toByteArray "byte[]"
%typemap(jstype) std::string ExplicitBitVect::toByteArray "byte[]"
%typemap(javaout) std::string ExplicitBitVect::toByteArray {
  return $jnicall;
}
%typemap(out) std::string ExplicitBitVect::toByteArray {
  $result = JCALL1(NewByteArray, jenv, $1.size());
  JCALL4(SetByteArrayRegion, jenv, $result, 0, $1.size(), (const jbyte*)$1.c_str());
}

#endif

%typemap(javacode) ExplicitBitVect %{
     public static ExplicitBitVect fromByteArray(byte[] fp) {
     UChar_Vect vec = new UChar_Vect();
     vec.reserve(fp.length);
     for (int size=0;size<fp.length;++size) {
       vec.add(fp[size]);
     }
     return new ExplicitBitVect(vec);
   }
%}

%include <DataStructs/ExplicitBitVect.h>
%newobject ExplicitBitVect::getOnBits;
%extend ExplicitBitVect {
	IntVect *getOnBits() {
	  IntVect* bits = new IntVect;
	  ($self)->getOnBits(*bits);
	  return bits;
	}
}

#ifdef SWIGJAVA

%extend ExplicitBitVect {
	const std::string toByteArray() {
		return ($self)->toString();
	}

	ExplicitBitVect(const std::vector<unsigned char> & data ) {
    	std::string str(data.begin(), data.end());
    	return new ExplicitBitVect(str);
  	}
}

#endif

